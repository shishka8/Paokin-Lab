using System;

namespace AutoApp
{

    class Автомобиль
    {

        protected string _марка;
        protected string _госномер;

        public string Марка
        {
            get { return _марка; }
            set { _марка = value; }
        }
        public string Госномер
        {
            get { return _госномер; }
            set { _госномер = value; }
        }

        
        public Автомобиль() { }

        public Автомобиль(string марка, string госномер)
        {
            _марка = марка;
            _госномер = госномер;
        }

        public virtual void Показать()
        {
            Console.WriteLine("Автомобиль: марка - {0}, номер - {1}", _марка, _госномер);
        }
    }

    class ЛегковойАвтомобиль : Автомобиль
    {
        protected int _число_мест;

        public int Число_мест
        {
            get { return _число_мест; }
            set { if (value > 0) _число_мест = value; }
        }

        public ЛегковойАвтомобиль() { }

        public ЛегковойАвтомобиль(string марка, string госномер, int места) : base(марка, госномер)
        {
            _число_мест = места;
        }

        public override void Показать()
        {
            Console.WriteLine("Легковой автомобиль: марка - {0}, номер – {1}, число пассажирских мест – {2}",
                _марка, _госномер, _число_мест);
        }
    }

    class ГрузовойАвтомобиль : Автомобиль
    {
        protected double _грузоподъемность;

        public double Грузоподъемность
        {
            get { return _грузоподъемность; }
            set { if (value > 0) _грузоподъемность = value; }
        }

        public ГрузовойАвтомобиль() { }

        public ГрузовойАвтомобиль(string марка, string госномер, double тонн) : base(марка, госномер)
        {
            _грузоподъемность = тонн;
        }

        public override void Показать()
        {
            Console.WriteLine("Грузовой автомобиль: марка - {0}, номер – {1}, грузоподъемность – {2} т.",
                _марка, _госномер, _грузоподъемность);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Автомобиль generic = new Автомобиль("Lada", "А001АА");
            ЛегковойАвтомобиль porsche = new ЛегковойАвтомобиль("Porsche", "Х777ХХ", 2);
            ГрузовойАвтомобиль kamaz = new ГрузовойАвтомобиль("Камаз", "М123ОР", 15.5);

            generic.Показать();
            porsche.Показать();
            kamaz.Показать();

            Console.ReadKey();
        }
    }
}