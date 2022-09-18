package lab05.dp.tdtu;

import lab05.dp.tdtu.Account;

import lab05.dp.tdtu.AccountType;

import lab05.dp.tdtu.InterestStrategy;

public class SavingAccount extends Account {

    public SavingAccount(long accountNo, String accountHolderName) {

        super(accountNo, accountHolderName, AccountType.SAVING);

        setInterestStrategy(InterestStrategy.COMPOUND);

    }

    @Override

    public double getInterest(int term) {

        return this.getInterestStrategy().getInterest(accountType, amount, term);

    }

}