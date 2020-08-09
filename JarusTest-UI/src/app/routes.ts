import { Routes } from '@angular/router';

import { QuotesComponent } from './quotes/quotes.component';
import { PeopleComponent } from './people/people.component';

export const appRoutes: Routes = [
    { path: 'quote', component: QuotesComponent },
    { path: 'people', component: PeopleComponent },
    { path: '**', redirectTo: 'quote', pathMatch: 'full' }
];
