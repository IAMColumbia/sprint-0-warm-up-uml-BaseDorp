namespace Sprint_0_Warm_Up
{
    public class Engine : IEngine
    {
        public bool IsStarted { get; set; }

        public string About()
        {
            if (IsStarted)
            {
                return $"{this.ToString()} is started";
            }
            else
            {
                return $"{this.ToString()} is not started";
            }
        }

        public Engine()
        {
            IsStarted = false;
        }

        public void Start()
        {
            this.IsStarted = true;
        }

        public void Stop()
        {
            this.IsStarted = false;
        }
    }
}