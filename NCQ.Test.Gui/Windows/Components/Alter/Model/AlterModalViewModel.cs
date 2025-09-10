namespace NCQ.Test.Gui.Windows.Components.Alter
{
    public class AlterModalViewModel
    {
        public virtual string Id { get; set; }
        public virtual string Description { get; set; }

        public static AlterModalViewModel CreateDefault()
        {
            return new AlterModalViewModel()
            {
                Description = "Lol"
            };
        }
    }
}
