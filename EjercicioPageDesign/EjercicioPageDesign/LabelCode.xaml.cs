using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjercicioPageDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var underlineLabel = new Label { Text = "This is underlined text.",
                TextDecorations = TextDecorations.Underline,FontSize=30 };
            
            var strikethroughLabel = new Label { Text = "This is text with strikethrough.",
                TextDecorations=TextDecorations.Strikethrough,
                FontSize = 20
            };
            var bothLabel=new Label { Text = "This is underlined text with strikethrough",
                TextDecorations = TextDecorations.Underline | TextDecorations.Strikethrough,
                FontSize = 20
            };

            stack.Children.Add(underlineLabel);
            stack.Children.Add(strikethroughLabel);
            stack.Children.Add(bothLabel);
            Content = stack;
        
        }
    }
}