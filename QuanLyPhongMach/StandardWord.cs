using System.Globalization;

namespace QuanLyPhongMach
{
    class StandardWord
    {
        public string Standard_Word(string s)
        {
            string str = s.Trim();
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);

            // thay thế các chuỗi khoảng trắng liên tiếp nhau thành duy nhất 1 khoảng trắng
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");

            return textInfo.ToTitleCase(str);
        }
    }
}
