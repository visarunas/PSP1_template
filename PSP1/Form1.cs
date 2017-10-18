using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSP1
{
    public partial class Form1 : Form
    {
        Entity player = new Entity(new WeaponSword());
        Entity enemy = new Entity(new WeaponSpear());

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            richTextBox1.Text += "Attacking enemy\n";
            var damage = player.weapon.GetAttackDamage(player, enemy);
            richTextBox1.Text += "Damage to enemy: " + damage + "\n";
            enemy.health -= damage;

            richTextBox1.Text += "Enemy attacking Player\n";
            damage = enemy.weapon.GetAttackDamage(enemy, player);
            richTextBox1.Text += "Damage to Player: " + damage + "\n";
            player.health -= damage;


        }
    }
}
