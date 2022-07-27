﻿namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: My intial state is: " + state);
        }

        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to {_state}");
        }

        private string GenerateRandomString(int length = 30)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
                throw new Exception($"Unknown memento class: " + memento.ToString());

            _state = memento.GetState();
            Console.WriteLine($"Originator: My state has changed to {_state}");
        }
    }

    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }

    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        public string GetState()
        {
            return _state;
        }
    }

    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine($"\nCaretaker: Saving Originator's state...");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
                Console.WriteLine(memento.GetName());
        }

    }
}
