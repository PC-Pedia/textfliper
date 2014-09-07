using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	int Time = 1 ;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnFlipButton (object sender, EventArgs e)
	{

		int CurrentChar = 0;
		string text = PadOne1.Buffer.Text;

		Console.WriteLine ("> Fixing Persian symbols.");

		text = text.Replace ( "ﺴ" , "س" ) ;
		text = text.Replace ( "ﺳ" , "س" ) ;
		text = text.Replace ( "ﺲ" , "س" ) ;
		text = text.Replace ( "ﺼ" , "ص" ) ;
		text = text.Replace ( "ﺻ" , "ص" ) ;
		text = text.Replace ( "ﺸ" , "ش" ) ;
		text = text.Replace ( "ﺷ" , "ش" ) ;
		text = text.Replace ( "ﺶ" , "ش" ) ;
		text = text.Replace ( "ﺰ" , "ز" ) ;
		text = text.Replace ( "ﺯ" , "ز" ) ;
		text = text.Replace ( "ﻤ" , "م" ) ;
		text = text.Replace ( "ﻣ" , "م" ) ;
		text = text.Replace ( "ﻢ" , "م" ) ;
		text = text.Replace ( "ﻡ" , "م" ) ;
		text = text.Replace ( "ﻂ" , "ط" ) ;
		text = text.Replace ( "ﻁ" , "ﻁ" ) ;
		text = text.Replace ( "ﻬ" , "ه" ) ;
		text = text.Replace ( "ﻫ" , "ه" ) ;
		text = text.Replace ( "ﻪ" , "ه" ) ;
		text = text.Replace ( "ز" , "ﺯ" ) ;
		text = text.Replace ( "ﺰ" , "ز" ) ;
		text = text.Replace ( "ﻀ" , "ض" ) ;
		text = text.Replace ( "ﺿ" , "ض" ) ;			
		text = text.Replace ( "ﺾ" , "ض" ) ;
		text = text.Replace ( "ﺽ" , "ض" ) ;
		text = text.Replace ( "ﻴ" , "ی" ) ;
		text = text.Replace ( "ﻳ" , "ی" ) ;
		text = text.Replace ( "ﻲ" , "ی" ) ;
		text = text.Replace ( "ﻱ" , "ی" ) ;
		text = text.Replace ( "ﻰ" , "ی" ) ;
		text = text.Replace ( "ﻘ" , "ق" ) ;
		text = text.Replace ( "ﻗ" , "ق" ) ;
		text = text.Replace ( "ﻖ" , "ق" ) ;
		text = text.Replace ( "ﺨ" , "خ" ) ;
		text = text.Replace ( "ﺧ" , "خ" ) ;
		text = text.Replace ( "ﺦ" , "خ" ) ;
		text = text.Replace ( "ﺥ" , "خ" ) ;
		text = text.Replace ( "ﻅ" , "ظ" ) ;
		text = text.Replace ( "ﻆ" , "ظ" ) ;
		text = text.Replace ( "ﻇ" , "ظ" ) ;
		text = text.Replace ( "ﻜ" , "ک" ) ;
		text = text.Replace ( "ﻛ" , "ک" ) ;
		text = text.Replace ( "ﻚ" , "ک" ) ;
		text = text.Replace ( "ﻙ" , "ک" ) ;
		text = text.Replace ( "ﻨ" , "ن" ) ;
		text = text.Replace ( "ﻧ" , "ن" ) ;
		text = text.Replace ( "ﻦ" , "ن" ) ;
		text = text.Replace ( "ﻥ" , "ن" ) ;
		text = text.Replace ( "ﻓ" , "ف" ) ;
		text = text.Replace ( "ﻔ" , "ف" ) ;
		text = text.Replace ( "ﻓ" , "ف" ) ;
		text = text.Replace ( "ﻒ" , "ف" ) ;
		text = text.Replace ( "ﻟ" , "ل" ) ;
		text = text.Replace ( "ﻞ" , "ل" ) ;
		text = text.Replace ( "ﭗ" , "پ" ) ;
		text = text.Replace ( "ﭘ" , "پ" ) ;
		text = text.Replace ( "ﭙ" , "پ" ) ;
		text = text.Replace ( "ﺐ" , "ب" ) ;
		text = text.Replace ( "ﺏ" , "ب" ) ;
		text = text.Replace ( "ﺮ" , "ر" ) ;
		text = text.Replace ( "ﻐ" , "غ" ) ;
		text = text.Replace ( "ﻏ" , "غ" ) ;
		text = text.Replace ( "ﻏ" , "غ" ) ;
		text = text.Replace ( "ﻎ" , "غ" ) ;
		text = text.Replace ( "ﻍ" , "غ" ) ;
		text = text.Replace ( "ﺌ" , "ﺉ" ) ;
		text = text.Replace ( "ﺋ" , "ﺉ" ) ;
		text = text.Replace ( "ﺊ" , "ﺉ" ) ;
		text = text.Replace ( "ﺉ" , "ﺉ" ) ;
		text = text.Replace ( "ﺬ" , "ذ" ) ;
		text = text.Replace ( "ﺫ" , "ذ" ) ;
		text = text.Replace ( "ﺬ" , "ﺪ" ) ;
		text = text.Replace ( "ﺩ" , "د" ) ;
		text = text.Replace ( "ﺤ" , "ح" ) ;
		text = text.Replace ( "ﺣ" , "ح" ) ;
		text = text.Replace ( "ﺢ" , "ح" ) ;
		text = text.Replace ( "ﺡ" , "ح" ) ;

		string TempPersian = "";
		string TempEnglish = "";
		string FinalText = "";

		Console.WriteLine ("\n\n> Season " + Time + ": started");

		int TextPercentSize = text.Length / 100 ;
		int MyCharCounter = 0 ;
		int Percent = 0 ;
		Console.Clear () ;

		string MyChar = text [CurrentChar] .ToString ();

		List <string> PersianChars = new List<string> 
		{
			
 				"ا","ب","پ","ت","ث","ج","چ","ح","خ","د","ذ",             
"ر","ز","ژ","س","ش","ص","ض","ط","ظ","ع"," ","غ"					
,"ف","ق","ک","گ","ل","م","ن","و","ه","ی"	,			 


			 /////////////////////////////////////////////////

			
	"ء","إ","ؤ","آ","،","ژ","پ","و","ئ","د","ذ","ر","ز","ط","ظ","م","ن","ت","ا"				
,"ل","ب","ی","س","ش","چ","ج","ح","خ","ه","ع","غ","ف","ق","ث","ص","ض",			  
			
		};

		while (CurrentChar < text.Length) {
		
			string TheChar = text [CurrentChar] .ToString ();

			if (PersianChars.Exists (element => element == TheChar)) {

				FinalText = FinalText + TempEnglish;
				TempEnglish = "";
				TempPersian = TheChar + TempPersian;

			} else {

				FinalText = FinalText + TempPersian;
				TempPersian = "";
				TempEnglish = TempEnglish + TheChar;

			}



			if ( MyCharCounter == TextPercentSize ) {

				if ( Percent <= 100 ) {

					Console.WriteLine (": " + Percent + "%" );

				}

				Percent ++ ;
				MyCharCounter = 0 ;
			}

			MyCharCounter ++ ;
			CurrentChar ++;
		}

		string TheChar2 = text [CurrentChar - 1] .ToString ();
		if (PersianChars.Exists (element => element == TheChar2)) {

			FinalText = FinalText + TempPersian ;
		
		} else {

			FinalText = FinalText + TempEnglish ;

		}

		Console.WriteLine ("> Season " + Time + ": complete");
		Time ++ ;

		PadTwo.Buffer.Text = FinalText ;
	}
}