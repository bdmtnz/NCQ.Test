using System;

namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public class AlterModalViewModel
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual long StatusId { get; set; }
        public virtual long PriorityId { get; set; }
        public virtual string Notes { get; set; }
        public virtual DateTime? Commitment { get; set; }
        public virtual string Title => Id == default ? "Nueva tarea" : "Editar tarea";

        public static AlterModalViewModel CreateDefault()
        {
            return new AlterModalViewModel()
            {
                Description = "",
                Commitment = null
            };
        }
    }
}
