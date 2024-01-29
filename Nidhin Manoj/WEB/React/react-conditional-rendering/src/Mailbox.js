import React from 'react';

const Mailbox = (props) => 
{const unreadMessages=props.unreadMessage;
    return (
        <div>
          <h1>Hello!</h1>
          {unreadMessages> 0 && <h1>you have {unreadMessages} unread Messages</h1>} 
        </div>
    );
}

export default Mailbox;
