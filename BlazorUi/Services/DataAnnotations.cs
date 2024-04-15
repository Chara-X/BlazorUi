using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace BlazorUi.Services;

public class DataAnnotationsVerifier
{
    public static IEnumerable<ValidationAttribute> GetValidationAttributes<T>(Expression<Func<T>> valueExpression) => GetValidationAttributes(((MemberExpression)valueExpression.Body).Member);
    public static IEnumerable<ValidationAttribute> GetValidationAttributes(MemberInfo member) => member.GetCustomAttributes<ValidationAttribute>();
}