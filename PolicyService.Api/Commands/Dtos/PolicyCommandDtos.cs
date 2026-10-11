namespace PolicyService.Api.Commands.Dtos;

public class PersonDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TaxId { get; set; }
}

public class AddressDto
{
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
}

public enum QuestionType
{
    Numeric,
    Choice
}

public abstract class QuestionAnswer
{
    public string QuestionCode { get; set; }
    public abstract QuestionType QuestionType { get; }
}

public class ChoiceQuestionAnswer : QuestionAnswer
{
    public string Answer { get; set; }
    public override QuestionType QuestionType => QuestionType.Choice;
}

public class NumericQuestionAnswer : QuestionAnswer
{
    public decimal Answer { get; set; }
    public override QuestionType QuestionType => QuestionType.Numeric;
}