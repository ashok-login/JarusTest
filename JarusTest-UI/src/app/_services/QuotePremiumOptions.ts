import { Deserializable } from '../_models/deserializable';

export class QuotePremiumOptions implements Deserializable {
    public basic: number;
    public preferred: number;
    public premier: number;

    deserialize(input: any): this {
        return Object.assign(this, input);
    }
}
