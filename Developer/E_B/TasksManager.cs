using E_B.task;
using E_B.task.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_B
{
    class TasksManager : Tasks
    {
        private readonly List<Service> Services = new List<Service>();
        private task.service.Status Status { get; set; } = task.service.Status.Install;

        public Service Get(Type Type)
        {
            if (this.Services.Any(x => x.Type == Type))
                return this.Services.Single(x => x.Type == Type);
            return Add(new Service(Type, this.Network));
        }
        private Service Add(Service Service) {
            Service.Handler += Check;
            Services.Add(Service);
            return Service;
        }
        private readonly E_C.Network Network;
        private Action? _Handler;
        public event Action Handler {
            add => _Handler += value;
            remove => _Handler -= value;
        }

        Service[] Tasks.Services => this.Services.ToArray();


        Status Tasks.Status => this.Status;

        private void Check() {
            var _Status = (Network.Status.Equals(E_C.network.Status.Offline) || Services.Any(x => x.Status.Equals(task.service.Status.Install))) ? task.service.Status.Install : Services.Any(x => x.Status.Equals(task.service.Status.Download)) ? task.service.Status.Download : task.service.Status.Done;
            if (Status == _Status) return;
            Status = _Status;
        }

        public TasksManager(E_C.Network Network) => (this.Network = Network).Handler += Check;


    }
}
