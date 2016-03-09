namespace Docker.DotNet.Models
{
    public class CreateContainerParameters
    {
        public Config Config { get; set; }

        [QueryStringParameter("name", false)]
        public string ContainerName { get; set; }

        public CreateContainerParameters()
        {
        }
    }

    public class CreateContainerParameters_V121
    {
        public Config_V121 Config { get; set; }

        [QueryStringParameter("name", false)]
        public string ContainerName { get; set; }

        public CreateContainerParameters_V121()
        {
        }
    }
}