namespace DBMS.Core.Columns
{
    public class TimeColumn : Column
    {
        public override string Type { get; set; } = "TIME";

        public TimeColumn(string name) : base(name) { }

        public override bool Validate(string value) => 
            TimeOnly.TryParse(value, out _) || value == "";
    }


}