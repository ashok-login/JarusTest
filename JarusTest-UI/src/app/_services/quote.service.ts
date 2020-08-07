import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Quote } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class QuoteService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getQuotes(): Observable<Quote[]> {
    return this.http.get<Quote[]>(this.baseUrl + 'quotes')
        .map()
  }
}
