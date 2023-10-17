namespace DBMS.Core.Columns
{
    public class TimeIntervalColumn : Column
    {
        public override string Type { get; set; } = "TIME INTERVAL";

        public TimeIntervalColumn(string name) : base(name) { }

        public override bool Validate(string value)
        {
            string[] buf = value.Replace(" ", "").Split(',');

            return (buf.Length == 2 && TimeOnly.TryParse(buf[0], out TimeOnly a) &&
              TimeOnly.TryParse(buf[1], out TimeOnly b) && a<b) || value == "";
        }
    }


}