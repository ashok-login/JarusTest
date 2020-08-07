import { PremiumOptions } from './premium-options';
import { Deserializable } from './deserializable';

export interface Quote implements Deserializable {
    quoteId: number;
    quoteNumber: string;
    status: string;
    applicant: string;
    quoteDate: Date;
    quoteEffectiveDate: Date;
    premiumOptions: PremiumOptions;

    public deserialize(input: any): this {
        Object.assign(this, input);
    }
}
