using Maskinpark.Data.Enitites;
using Microsoft.AspNetCore.Components;

namespace MaskinparkApp.Pages
{
    public partial class MachineDetail
    {
        [Parameter]
        public string MachineId { get; set; }
        public Machine Machine { get; set; } = new Machine();

        public IEnumerable<Machine> Machines { get; set; }
        public List<MachineType> MachineTypes { get; set; }
        public List<Status> Statuses { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeMachine();
            Machine = Machines.FirstOrDefault(m => m.MachineId == int.Parse(MachineId));

            return base.OnInitializedAsync();
        }

        private void InitializeMachine()
        {

        }
        //Machines = new List<Machine>
    }
}
