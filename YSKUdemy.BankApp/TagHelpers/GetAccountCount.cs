using Microsoft.AspNetCore.Razor.TagHelpers;
using YSKUdemy.BankApp.Data.Contexts;

namespace YSKUdemy.BankApp.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount : TagHelper
    {
        private readonly AppDbContext _context;
        public int AppUserId { get; set; }


        public GetAccountCount(AppDbContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var count = _context.Accounts.Count(x => x.AppUserId == AppUserId);
            var html = $"<span class=\"badge badge-lg bg-primary rounded-pill\">{count}</span>";
            output.Content.SetHtmlContent(html);
            base.Process(context, output);
        }
    }
}
