using System.ComponentModel;
using System.Reflection;

namespace ChatWeb.Trainning.DomainCore.Extensions
{
    public static class GenericEnumExtensionDescription
    {
        public static string ObterDescricao(this Enum _enum)
        {
            Type generEnumType = _enum.GetType();
            MemberInfo[] memberInfo = generEnumType.GetMember(_enum.ToString());
            if (memberInfo.Length <= 0) return _enum.ToString();

            var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attrs.Length > 0 ? ((DescriptionAttribute)attrs[0]).Description : _enum.ToString();
        }
    }
}

