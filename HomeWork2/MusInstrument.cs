﻿namespace HomeWork2
{
    internal class MusInstrument
    {
        private string _name;
        private string _description;

        public MusInstrument(string _name, string _description)
        {
            this._name = _name;
            this._description = _description;
        }

        public virtual void Sound()
        {
            Print("Sound");
        }

        public void Show()
        {
            Print($"Название инструмента {_name}");
        }

        public void Desc()
        {
            Print($"Описание муз. предмета: {_description}");
        }
        //добавил виртуальный метод для практики с override
        public virtual void History()
        {
            Print("History");
        }

        public void Print(string msg)
        {
            Console.WriteLine("\n" + msg + "\n");
        }
    }
}
