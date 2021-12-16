namespace Collatz
{
    public struct ConjectureResults
    {
        int chainLength;
        int chainNumber;

        public int ChainLength{
            set {chainLength = value;}
            get {return chainLength;}
        }
        public int ChainNumber{
            set {chainNumber = value;}
            get {return chainNumber;}
        }
    }
}