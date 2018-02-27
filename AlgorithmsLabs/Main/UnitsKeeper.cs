using System.Collections.Generic;

namespace AlgorithmsLabs
{
    public struct Unit
    {
        public string form;
        public string name;
        public Unit(string _form, string _name)
        {
            form = _form;
            name = _name;
        }
    }

    class UnitsKeeper
    {
        static public List<Unit> Units = new List<Unit>
        {
            new Unit("AlgorithmsLabs.FindForm", "Поиск"),
            new Unit("AlgorithmsLabs.SortForm", "Сортировка"),
            new Unit("AlgorithmsLabs.MergeForm", "Слияние"),

        };
    }
}
