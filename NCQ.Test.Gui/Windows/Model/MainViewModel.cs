using System;

namespace NCQ.Test.Gui.Windows.Model
{
    public class MainViewModel
    {
        public virtual long StatusId { get; set; }
        public virtual long PriorityId { get; set; }
        public virtual DateTime? CommitmentStart { get; set; }
        public virtual DateTime? CommitmentEnd { get; set; }

        public static MainViewModel CreateDefault()
        {
            return new MainViewModel()
            {
                StatusId = default,
                PriorityId = default,
                CommitmentStart = null, 
                CommitmentEnd = null,
            };
        }

        public void Reset()
        {
            StatusId = default;
            PriorityId = default;
            CommitmentStart = null;
            CommitmentEnd = null;
        }
    }
}
