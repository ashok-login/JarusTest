import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Quote } from '../_models/quote';
import { QuoteService } from '../_services/quote.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.css']
})
export class QuotesComponent implements OnInit {
  quotes: Quote[];
  premiumStatuses: string[];
  constructor(private quoteService: QuoteService, private alertify: AlertifyService,
              protected router: Router) { }

  ngOnInit() {
    this.getQuotes();
    this.getPremiumStatuses();
  }

  getQuotes() {
    this.quoteService.getQuotes().subscribe((quotes: any[]) => {
      this.quotes = quotes;
    }, error => {
      this.alertify.error(error);
    });
  }

  getPremiumStatuses(): string[] {
    return new Array('Pending', 'Issued');
  }
}
