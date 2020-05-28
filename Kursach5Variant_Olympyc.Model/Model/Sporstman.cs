namespace Kursach5Variant_Olympyc.Model.Model
{
    public sealed class Sporstman
    {
        public int    Registration_ID { get; set; }
        public string FirstName       { get; set; }
        public string LastName        { get; set; }
        public string Patronymic      { get; set; }
        public string Country         { get; set; }
        public string TypeOfCompetition { get; set; }
        public int Place              { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Country} in {TypeOfCompetition} took {Place} place";
        }

        public override bool Equals(object obj)
        {
            if (((Sporstman)obj).FirstName == this.FirstName && ((Sporstman)obj).LastName == this.LastName)
                return true;

            if (obj.GetType() == this.GetType())
                return true;

            return false;
        }
        //НАписано просто для переопредления в комбинации с Equals методом 
        public override int GetHashCode()
        {
            return this.Registration_ID + 1000;
        }
    }
}