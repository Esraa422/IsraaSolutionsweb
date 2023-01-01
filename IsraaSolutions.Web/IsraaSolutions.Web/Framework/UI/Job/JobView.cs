using System.Collections.Generic;
using IsraaApp.Core.Entities;

namespace IsraaApp.WebMVC.Framework.UI
{
    public class JobView : ViewComponentBase
    {
        public JobView()
        {
            this.Items = new List<Job>();
            this.Variation = JobViewVariation.Variation1;
        }

        public List<Job> Items { get; set; }
        public List<JobCategory> AllCategories { get; set; }
        public SliderBuilder Slider { get; set; }

        public JobViewVariation Variation { get; set; }

        public override void GenerateHtmlAtributes()
        {
        }
    }

    public enum JobViewVariation
    {
        Variation1,
        Variation2
    }
}