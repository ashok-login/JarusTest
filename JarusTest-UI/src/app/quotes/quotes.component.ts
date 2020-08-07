import { Component, OnInit } from '@angular/core';

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
  constructor(private quoteService: QuoteService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.getQuotes();
  }

  getQuotes() {
    this.quoteService.getQuotes().subscribe((quotes: Quote[]) => {
      this.quotes = quotes;
    }, error => {
      this.alertify.error(error);
    });
  }
}
