using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {

        int money = 0;
        int multiplier = 1;
        int nextMultiplier = 10;
        int nextMultiplierPrice = 50;
        int autoClickDelay = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonMakeMoney_Click(object sender, EventArgs e)
        {
            money += multiplier;
            UpdateMoneyDisplay(money);
        }

        /// <summary>
        /// Update the money display textbox
        /// </summary>
        /// <param name="newValue">The value to display in the textbox.</param>
        private void UpdateMoneyDisplay(int newValue)
        {
            textBoxMoney.Text = newValue.ToString();
        }

        private void Button10xMultiplier_Click(object sender, EventArgs e)
        {
            if (money >= nextMultiplierPrice)
            {
                money -= nextMultiplierPrice;
                multiplier = nextMultiplier;
                UpdateMoneyDisplay(money);
                switch (nextMultiplier)
                {
                    case 10:
                        nextMultiplier = 50;
                        nextMultiplierPrice = 1000;
                        break;
                    case 50:
                        nextMultiplier = 200;
                        nextMultiplierPrice = 25000;
                        break;
                    default:
                        break;
                }
                button10xMultiplier.Text = nextMultiplier.ToString() + "x Multiplier\n" + nextMultiplierPrice.ToString() + " moneys";
            }
        }

        private void ButtonAutoClick_Click(object sender, EventArgs e)
        {
            if (money >= 200)
            {
                money -= 200;
                autoClickDelay = 3;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            /*
            Thread autoClickerThread = new Thread(AutoClickerThread);
            autoClickerThread.Start();
            */
            // ^^^^^^^^^^^^ Old Code!

            var autoClickerDataReturn = new Progress<string>(s => textBoxMoney.Text = s);
            await Task.Factory.StartNew(() => SecondThread.AutoClicker(autoClickerDataReturn));
        }

        /*public void AutoClickerThread()
        {
            Thread.Sleep(5000);
            

            
            while (true)
            {
                if (autoClickDelay != 0)
                {
                    Thread.Sleep(autoClickDelay);
                }
            }
            
        }
        */ // old code!
    }

    class SecondThread
    {
        public static void AutoClicker(IProgress<string> newMoneyValue)
        {
            Task.Delay(5000).Wait();
            newMoneyValue.Report("cheese!");
        }
    }
}