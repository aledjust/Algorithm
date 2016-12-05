using System;
using System.Linq;

namespace Algorithm
{
    public class NumberToWords
    {
        private static readonly
        string[] satuan =
                new[] {
						"nol", "satu", "dua",
						"tiga", "empat",
						"lima", "enam", "tujuh",
						"delapan", "sembilan"
				};


        private static readonly
                string[] belasan =
                        new[] {
						"sepuluh", "sebelas", "dua belas",
						"tiga belas", "empat belas",
						"lima belas", "enam belas",
						"tujuh belas",
						"delapan belas", "sembilan belas"
				};


        private static readonly
                string[] puluhan =
                        new[] {
						"", "", "dua puluh",
						"tiga puluh", "empat puluh",
						"lima puluh", "enam puluh",
						"tujuh puluh", "delapan puluh",
						"sembilan puluh"
				};


        private static readonly
                string[] ribuan =
                        new[] {
						"", "ribu", "juta",
						"milyar", "triliyun"
				};

        public static string NumberToWords(Decimal number)
        { 
            
            string strResult;
            Decimal frac = number - Decimal.Truncate(number);

            if (Decimal.Compare(frac, 0.0m) != 0)
            {
                strResult = NumberToWords(Decimal.Round(frac * 100)) + " sen";
            }
            else
            {
                strResult = "rupiah";
            }

            string strTemp = Decimal.Truncate(number).ToString();

            for (int i = strTemp.Length; i > 0; i--)
            {
                int nDigit = Convert.ToInt32(strTemp.Substring(i - 1, 1));
                int nPos = (strTemp.Length - i) + 1;
                switch (nPos % 3)
                {
                    case 1:
                        bool bAllZeros = false;
                        string tmpBuff;
                        if (i == 1)
                        {
                            tmpBuff = satuan[nDigit] + " ";
                        }
                        else if (strTemp.Substring(i - 2, 1) == "1")
                        {
                            tmpBuff = belasan[nDigit] + " ";
                        }
                        else if (nDigit > 0)
                        {
                            tmpBuff = satuan[nDigit] + " ";
                        }
                        else
                        {
                            bAllZeros = true;
                            if (i > 1)
                            {
                                if (strTemp.Substring(i - 2, 1) != "0")
                                {
                                    bAllZeros = false;
                                }
                            }
                            if (i > 2)
                            {
                                if (strTemp.Substring(i - 3, 1) != "0")
                                {
                                    bAllZeros = false;
                                }
                            }
                            tmpBuff = "";
                        }

                        if ((!bAllZeros) && (nPos > 1))
                        {
                            if ((strTemp.Length == 4) &&
                                (strTemp.Substring(0, 1) == "1"))
                            {
                                tmpBuff =
                                        "se" +
                                        ribuan[(int)Decimal.Round(nPos / 3m)] + " ";
                            }
                            else
                            {
                                tmpBuff +=
                                        ribuan[(int)Decimal.Round(nPos / 3)] + " ";
                            }
                        }
                        strResult = tmpBuff + strResult;
                        break;
                    case 2:
                        if (nDigit > 0)
                        {
                            strResult =
                                    puluhan[nDigit] + " " + strResult;
                        }
                        break;
                    case 0:
                        if (nDigit > 0)
                        {
                            if (nDigit == 1)
                            {
                                strResult =
                                        "seratus " + strResult;
                            }
                            else
                            {
                                strResult =
                                        satuan[nDigit] + " ratus " + strResult;
                            }
                        }
                        break;
                }
            }

            strResult = strResult.Trim().ToLower();

            if (strResult.Length > 0)
            {
                strResult = strResult.Substring(0, 1).ToUpper() +
                            strResult.Substring(1, strResult.Length - 1);
            }

            return strResult;
        }
    }
}
