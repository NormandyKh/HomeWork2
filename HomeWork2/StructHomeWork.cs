namespace HomeWork2
{
    struct DecimalNumber
    {
        private int decimalValue;

        public DecimalNumber(int value)
        {
            decimalValue = value;
        }

        public int DecimalValue
        {
            get { return decimalValue; }
            set { decimalValue = value; }
        }

        public string ToBinary()
        {
            return Convert.ToString(decimalValue, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(decimalValue, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(decimalValue, 16).ToUpper();
        }
    }
}

