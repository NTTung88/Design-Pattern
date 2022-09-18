package lab05.dp.tdtu;

import lab05.dp.tdtu.AbstractAccountFactory;

import lab05.dp.tdtu.AccountOpeningDetails;

import lab05.dp.tdtu.AccountType;

public class DepositAccountFactory extends AbstractAccountFactory {

    @Override

    public DepositAccount createAccount(AccountOpeningDetails openingDetails) {

        if (openingDetails == null || openingDetails.isNotValid(true)) {

            throw new IllegalArgumentException("Account Opening Details are not valid!");

        }

        DepositAccount account = null;

        AccountType type = openingDetails.getAccountType();

        switch (type) {

        case RECURRING_DEPOSIT:

            account = new RecurringDepositAccount(openingDetails.getAccountNo(), openingDetails.getAccountHolderName(), openingDetails.getTermInMonths());

            break;

        case FIXED_DEPOSIT:

            account = new FixedDepositAccount(openingDetails.getAccountNo(), openingDetails.getAccountHolderName(), openingDetails.getTermInMonths());

            break;

        default:

            System.err.println("Unknown/unsupported account-type.");

        }

        return account;

    }

}