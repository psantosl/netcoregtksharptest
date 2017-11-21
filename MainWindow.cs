using System;
using Gtk;


namespace gtktest
{
    class MainWindow : Window
    {
        public MainWindow() : base(WindowType.Toplevel) 
        {
            VBox box= new VBox();


            Button b = new Button("Click me!");

            box.Add(new Label("Hey boy"));
            box.Add(b);
            box.Add(new HBox(true, 10));

            Add(box);

            ShowAll();
            b.Clicked += (sender, e) => this.Title = mCounter++.ToString();

            this.DeleteEvent += (sender, e) => {Console.WriteLine("good bye"); Application.Quit();};
        }

        int mCounter;
    }
}
