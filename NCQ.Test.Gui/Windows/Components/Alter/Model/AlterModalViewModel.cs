using System;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public class AlterModalViewModel
    {
        public virtual string Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string StatusId { get; set; }
        public virtual string PriorityId { get; set; }
        public virtual string Notes { get; set; }
        public virtual DateTime Commitment { get; set; }
        public virtual string Title => string.IsNullOrEmpty(Id) ? "Nueva tarea" : "Editar tarea";

        public static AlterModalViewModel CreateDefault()
        {
            return new AlterModalViewModel()
            {
                Description = ""
            };
        }
    }
}
