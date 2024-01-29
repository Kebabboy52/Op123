using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op123
{
    public class Scitala
    {


        private char[,] _matrix;
        private int _columns;
        private int _messageLength;
        public int Diameter { get; set; }
        public Scitala(int diameter)
        {
            Diameter = diameter;
            _matrix = new char[Diameter, Diameter];
            _columns = Diameter;
            _messageLength = 0;
        }

        public void ClearMatrix()
        {
            Array.Clear(_matrix, 0, _matrix.Length);
            _columns = 0;
            _messageLength = 0;
        }

        public int GetMessageLength()
        {
            return _messageLength;
        }

        public string Encrypt(string plaintext)
        {
            int rows = (int)Math.Ceiling((double)plaintext.Length / _columns);
            _messageLength = plaintext.Length;

            if (_matrix.GetLength(0) < rows || _matrix.GetLength(1) < _columns)
            {
                _matrix = new char[rows, _columns];
            }

            int index = 0;
            // Заполняем матрицу символами из исходного текста
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (index < plaintext.Length)
                    {
                        _matrix[i, j] = plaintext[index];
                        index++;
                    }
                    else
                    {
                        _matrix[i, j] = ' ';
                    }
                }
            }

            // Читаем зашифрованный текст по столбцам
            string ciphertext = "";
            for (int j = 0; j < _columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ciphertext += _matrix[i, j];
                }
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext)
        {
            int rows = (int)Math.Ceiling((double)ciphertext.Length / _columns);
            int index = 0;

            // Заполняем матрицу символами из зашифрованного текста
            for (int j = 0; j < _columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (index < ciphertext.Length)
                    {
                        _matrix[i, j] = ciphertext[index];
                        index++;
                    }
                }
            }

            // Читаем дешифрованный текст по строкам
            string plaintext = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    plaintext += _matrix[i, j];
                }
            }

            return plaintext.TrimEnd();
        }
    }
}
