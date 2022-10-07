namespace Maskinpark.Data.Enitites
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public MachineType MachineType { get; set; }
    }
}