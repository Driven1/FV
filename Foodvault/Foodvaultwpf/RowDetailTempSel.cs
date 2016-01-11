using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace TemplateSelectors
{
    class CustomRowDetailTemplateSelector : DataTemplateSelector  // wählt basierend auf flag das richtige Detailtemplate für die ausgewählte gridrow aus
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;
            FrameworkElement frameWorkElement = container as FrameworkElement;
            if (frameWorkElement != null)
            {
                bool NutActive = ((Foodvaultwpf.Inst_Ing)item).NutActive;
                if (NutActive == false)
                {
                    return frameWorkElement.FindResource("FalseTemp") as DataTemplate;
                }
                else
                {
                    return frameWorkElement.FindResource("TrueTemp") as DataTemplate;
                }
            }
            else return null;
        }
    }
}
