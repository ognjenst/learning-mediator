using MediatR;
using MediatRDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : Controller
{
    private readonly IMediator _mediator;
    
    public ContactsController(IMediator mediator) => _mediator = mediator;
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] Query query)
    {
        var contact = await _mediator.Send(query);
        return Ok(contact);
    }
    
    #region Nested Classes
    public class Query : IRequest<Contact>
    {
        public int Id { get; set; }
    }
    
    public class ContactHandler : IRequestHandler<Query, Contact>
    {
        private readonly ContactsContext _context;
        
        public ContactHandler(ContactsContext context) => _context = context;
        
        public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Contacts.FindAsync(request.Id);
        }
    }
    #endregion
}