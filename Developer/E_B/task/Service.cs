using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_B.task
{
    public class Service
    {
        public readonly Type Type;
        private readonly List<service.ToDo> ToDos = new List<service.ToDo>();
        internal Service(Type Type, E_C.Network Network) {
            this.Type = Type;
            Network.Handler += () => {
                if (Network.Status.Equals(E_C.network.Status.Online)) return;
                ToDos.Clear();
            };
        }
        public service.Status Status => ToDos.Any(x => x.Status == service.Status.Install) ? service.Status.Install : ToDos.Any(x => x.Status == service.Status.Download) ? service.Status.Download : service.Status.Done;
        private service.Status _Status = service.Status.Done;
        private Action? _Handler;
        public event Action Handler{
            add => _Handler += value;
            remove => _Handler -= value;
        }
        private void Check() {
            if (Status == _Status) return;
            _Status = Status;
            _Handler?.Invoke();
        }
        public void Start(service.Status Status) {
            ToDos.Add(new service.ToDo(Status, Guid.Empty));
            this.Check();
        }
        public void Stop(service.Status Status) {
            ToDos.RemoveAll(a => a.ID == Guid.Empty&&a.Status==Status);
            this.Check();
        }
        public void Start(service.Status Status,Guid ID)
        {
            ToDos.Add(new service.ToDo(Status, ID));
            this.Check();
        }
        public void Stop(Guid ID)
        {
            ToDos.RemoveAll(a => a.ID == ID);
            this.Check();
        }
    }
}
