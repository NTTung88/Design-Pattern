package lab05.dp.tdtu;


import lab05.dp.tdtu.Account;

import lab05.dp.tdtu.AccountOpeningDetails;

public abstract class AbstractAccountFactory {
    public abstract Account createAccount(AccountOpeningDetails opendingDetails);
}