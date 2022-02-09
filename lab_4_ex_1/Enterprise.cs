using System;

namespace lab_4_ex_1
{
    class Enterprise : IComparable<Enterprise>
    {
        private string month;
        private int plan;
        private int fact;
        private float percentDone;

        public Enterprise()
        {
        }

        public Enterprise(string month, int plan, int fact)
        {
            if (month != "Сiчень" && month != "Лютий" && month != "Березень" &&
                month != "Квiтень" && month != "Травень" && month != "Червень" &&
                month != "Липень" && month != "Серпень" && month != "Вересень" &&
                month != "Жовтень" && month != "Листопад" && month != "Грудень")
                throw new Exception("Такого мiсяця не iснує!");
            this.month = month;
            if (plan < 0 || fact < 0)
                throw new Exception("Плановий чи фактичний випуск продукції не може бути меншим за 0");
            this.plan = plan;
            this.fact = fact;
            percentDone = (float)fact / plan * 100f;
        }
        
        public string Month
        {
            get => month;
            set
            {
                if (value != "Сiчень" && value != "Лютий" && value != "Березень" &&
                    value != "Квiтень" && value != "Травень" && value != "Червень" &&
                    value != "Липень" && value != "Серпень" && value != "Вересень" &&
                    value != "Жовтень" && value != "Листопад" && value != "Груде&&")
                    throw new Exception("Такого місяця не існує!");
                month = value;
            }
        }

        public int Plan
        {
            get => plan;
            set => plan = value;
        }

        public int Fact
        {
            get => fact;
            set => fact = value;
        }

        public float PercentDone
        {
            get => percentDone;
            set => percentDone = value;
        }

        public void CalculatePercentDone()
        {
            this.PercentDone = (float) fact / plan * 100;
        }

        public int CompareTo(Enterprise? other)
        {
            if (other != null)
                return this.percentDone.CompareTo(other.PercentDone);
            throw new Exception("Не можна нічо сюда не передавати!");
        }
    }
}