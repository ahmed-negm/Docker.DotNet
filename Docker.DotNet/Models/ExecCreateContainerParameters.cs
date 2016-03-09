namespace Docker.DotNet.Models
{
    public class ExecCreateContainerParameters
    {
        public ExecCreateContainerConfig Config { get; set; }

        public ExecCreateContainerParameters()
        {

        }
    }

    public class ExecStartContainerParameters
    {
        public ExecStartContainerConfig Config { get; set; }

        public ExecStartContainerParameters()
        {

        }
    }
}
