namespace AbstractFactory
{
    class A : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new ADumb();
        }

        public ISmart GetSmart()
        {
            return new ASmart();
        }
    }

    class B : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new BDumb();
        }

        public ISmart GetSmart()
        {
            return new BSmart();
        }
    }

    class C : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new CDumb();
        }

        public ISmart GetSmart()
        {
            return new CSmart();
        }
    }
}
