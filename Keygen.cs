using System.IO.Compression;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace VisualParadigmKeygen
{
    class Keygen
    {
        private string serialNumber;
        private string installationId;
        private string activeCode;
        private string expireDate;
        private string email;
        private string machineInfo;
        private string name;
        private string productName;
        private string productVersion;
        private string productBuild;
        private string productRegisterDate;
        private string type;
        private string evaluation;
        private string verifyText;
        private string license;
        public string License(string _installationId, string _email, string _name, string _productName, string _productVersion, string _productBuild)
        {
            if (string.IsNullOrEmpty(_installationId) || _installationId.Length != 32 || string.IsNullOrEmpty(_email) || string.IsNullOrEmpty(_name))
            {
                return "Invalid or missing value";
            }
            serialNumber = GenerateRandomString(16, 16);
            installationId = _installationId;
            activeCode = GenerateRandomString(25, 32).ToUpper();
            expireDate = new DateTimeOffset(DateTime.Now.AddYears(2)).ToUnixTimeMilliseconds().ToString();
            email = _email;
            machineInfo = "C#";
            name = _name;
            productName = _productName;
            productVersion = _productVersion;
            productBuild = _productBuild;
            productRegisterDate = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds().ToString();
            type = "1";
            evaluation = "false";
            verifyText = serialNumber +
                         installationId +
                         activeCode +
                         expireDate +
                         email +
                         machineInfo +
                         name +
                         productName +
                         productVersion +
                         productBuild +
                         productRegisterDate +
                         type +
                         evaluation;
            license = string.Format(
               "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
               "<KeyType type=\"1\">\n" +
               "    <LicenseKey keyVersion=\"20020918\">\n" +
               "        <SerialNumber value=\"{0}\"/>\n" +
               "        <InstallationId value=\"{1}\"/>\n" +
               "        <ActivationCode value=\"{2}\"/>\n" +
               "        <ExpireDate value=\"{3}\"/>\n" +
               "        <EMail value=\"{4}\"/>\n" +
               "        <MachinelInfo value=\"{5}\"/>\n" +
               "        <UserName value=\"{6}\"/>\n" +
               "        <ProductName value=\"{7}\"/>\n" +
               "        <ProductVersion value=\"{8}\"/>\n" +
               "        <ProductBuild value=\"{9}\"/>\n" +
               "        <ProductRegisterDate value=\"{10}\"/>\n" +
               "        <Type value=\"{11}\"/>\n" +
               "        <Evaluation value=\"{12}\"/>\n" +
               "        <TagValue></TagValue>\n" +
               "        <VerifyKey value=\"{13}\"/>\n" +
               "    </LicenseKey>\n" +
               "</KeyType>\n",
               serialNumber,
               installationId,
               activeCode,
               expireDate,
               email,
               machineInfo,
               name,
               productName,
               productVersion,
               productBuild,
               productRegisterDate,
               type,
               evaluation,
               VerifyKey(verifyText)
           );
            using MemoryStream memoryStream = new();
            using ZipArchive zipArchive = new(memoryStream, ZipArchiveMode.Create, true);
            ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("license.vpl");
            byte[] bytes = Encoding.UTF8.GetBytes(license);
            using (Stream stream = zipArchiveEntry.Open())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            memoryStream.Write(Encoding.UTF8.GetBytes("asdkl12;390asxuasad_.,sd12-80sd"));
            return Convert.ToBase64String(memoryStream.ToArray());
        }
        private static string GenerateRandomString(int length, int radix)
        {
            int bits = length * 5;
            int bytes = (bits + 7) / 8;
            byte[] randomBytes = new byte[bytes];
            using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(randomBytes);
            }
            BigInteger bigInteger = new(randomBytes, isUnsigned: true, isBigEndian: true);
            string fullStr = ToBase(bigInteger, radix);
            return fullStr.Length > length ? fullStr[..length] : fullStr;
        }

        private static string ToBase(BigInteger value, int radix)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder stringBuilder = new();
            while (value > 0)
            {
                int remainder = (int)(value % radix);
                stringBuilder.Insert(0, chars[remainder]);
                value /= radix;
            }
            return stringBuilder.ToString();
        }

        private static string VerifyKey(string text)
        {
            byte[] original = Encoding.UTF8.GetBytes(text);
            sbyte[] result = new sbyte[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                result[i] = (sbyte)original[i];
            }

            sbyte p = result[0];
            for (int i = text.Length - 1; i >= 0; i--)
            {
                int temp = result[i] + (p + i) % 17;
                if (temp > 127)
                {
                    result[i] = (sbyte)(temp - 256);
                }
                else
                {
                    result[i] = (sbyte)temp;
                }
                p = result[i];
            }
            byte[] encoded = new byte[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                encoded[i] = (byte)result[i];
            }
            return Convert.ToBase64String(encoded);
        }

    }
}