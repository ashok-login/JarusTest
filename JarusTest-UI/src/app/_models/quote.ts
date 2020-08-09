export interface Quote {
    quoteId: number;
    quoteNumber: string;
    status: string;
    applicant: string;
    quoteDate: Date;
    quoteEffectiveDate: Date;
    premiumOptionsBasic: number;
    premiumOptionsPreferred: number;
    premiumOptionsPremier: number;
}
