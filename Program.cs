using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Israel;

public class Program 
{
    public string name;
    
    public void Show()
    {
        string shapeSelected = Console.ReadLine();

        Shape shape = null;
        switch (shapeSelected)
        {

            case "1":
                shape = new Francotirador (name, 7);
                break;

            case "2":
                shape = new Luchador (name,5);
                break;

            case "3":
                shape = new Sanador(name, 50);
                break;
        }


    }
}
