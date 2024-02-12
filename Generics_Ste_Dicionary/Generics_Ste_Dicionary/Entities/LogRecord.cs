namespace Generics_Ste_Dicionary.Entities
{
    public class LogRecord
    {
        public string User { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return User.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord)) return false;

            LogRecord other = obj as LogRecord;
            return User.Equals(other.User);
        }
    }
}
