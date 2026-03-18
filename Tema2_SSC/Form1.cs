using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Tema2_SSC
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();

        SymmetricAlgorithm mySymmetricAlg;
        public Form1()
        {
            InitializeComponent();
        }
         public void Generate(string cipher) 
        { 
            switch (cipher) 
            { 
                case "DES": 
                    mySymmetricAlg = DES.Create(); 
                    break; 
                case "3DES": 
                    mySymmetricAlg = TripleDES.Create(); 
                    break; 
                case "Rijndael": 
                    mySymmetricAlg = Rijndael.Create(); 
                    break; 
            }
            mySymmetricAlg.GenerateIV(); 
            mySymmetricAlg.GenerateKey(); 
        } 
 
        public byte[] Encrypt(byte[] mess, byte[] key, byte[] iv) 
        { 
            mySymmetricAlg.Key = key; 
            mySymmetricAlg.IV = iv; 
            System.IO.MemoryStream ms = new System.IO.MemoryStream(); 
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write); 
            cs.Write(mess, 0, mess.Length); 
            cs.Close(); 
            return ms.ToArray(); 
        } 
 
        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv) 
        { 
            byte[] plaintext = new byte[mess.Length]; 
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms,mySymmetricAlg.CreateDecryptor(),CryptoStreamMode.Read);
            cs.Read(plaintext, 0, mess.Length);
            cs.Close();
            return plaintext;
        } 

        private void buttonEnc_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            Generate(comboBoxCipher.Text);
            textBoxKey.Text =myConverter.ByteArrayToHexString(mySymmetricAlg.Key);
            textBoxIV.Text =myConverter.ByteArrayToHexString(mySymmetricAlg.IV); 
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
             byte[] plaintext  = Decrypt(myConverter.HexStringToByteArray(textBoxCipherHex.Text), myConverter.HexStringToByteArray(textBoxKey.Text),myConverter.HexStringToByteArray(textBoxIV.Text)); 
            textBoxPlain.Text = myConverter.ByteArrayToString(plaintext); 
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(plaintext);
        }

        private void buttonEncTime_Click(object sender, EventArgs e)
        {
              mySymmetricAlg.GenerateIV(); // generates a fresh IV 
            mySymmetricAlg.GenerateKey(); // generates a fresh Key 
 
            System.IO.MemoryStream ms = new System.IO.MemoryStream(); 
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write); 
            byte[] mes_block = new byte[mySymmetricAlg.BlockSize / 8]; ; 
            long start_time = DateTime.Now.Ticks; 
            int count = 10000000; 
            for (int i = 0; i < count; i++) 
            { 
                cs.Write(mes_block, 0, mes_block.Length); 
            } 
            cs.Close(); 
            double operation_time = (DateTime.Now.Ticks - start_time); 
            operation_time = operation_time / (10*count); // 1 tick is 100 ns, i.e., 1/10 of 1 us 
            labelEncTime.Text = "Time for encryption of a message block: " + operation_time.ToString() + " us"; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnc_Click_1(object sender, EventArgs e)
        {
            byte[] ciphertext = Encrypt(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.HexStringToByteArray(textBoxKey.Text), myConverter.HexStringToByteArray(textBoxIV.Text));
            textBoxCipher.Text = myConverter.ByteArrayToString(ciphertext);
            textBoxCipherHex.Text = myConverter.ByteArrayToHexString(ciphertext);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(myConverter.StringToByteArray(textBoxPlain.Text));
        }

        private void buttonDecTime_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV(); // IV nou
            mySymmetricAlg.GenerateKey(); // Key nou

            // cream un bloc de date criptat (fake)
            byte[] mes_block = new byte[8];

            // mai întâi îl criptăm o dată ca să avem ce decripta
            byte[] encrypted_block = Encrypt(mes_block, mySymmetricAlg.Key, mySymmetricAlg.IV);

            System.IO.MemoryStream ms = new System.IO.MemoryStream(encrypted_block);
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] output = new byte[encrypted_block.Length];

            long start_time = DateTime.Now.Ticks;
            int count = 10000000;

            for (int i = 0; i < count; i++)
            {
                ms.Position = 0; // reset stream
                cs.Read(output, 0, output.Length);
            }

            cs.Close();

            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count); // microsecunde

            label10.Text = "Time for decryption of a message block: " + operation_time.ToString() + " us";

        }
    }
}
