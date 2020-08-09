import { Component, OnInit } from '@angular/core';

import { Person } from '../_models/person';
import { PeopleService } from '../_services/people.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {
  people: Person[];

  constructor(private peopleService: PeopleService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.getPeople();
  }

  getPeople() {
    this.peopleService.getPeople().subscribe((people: any[]) => {
      this.people = people;
    }, error => {
      this.alertify.error(error);
    });
  }

  getPersonFullName(title: string, firstName: string, lastName: string) {
    // return title + '. ' + firstName + ' ' + lastName;
    return title.concat('. ').concat(firstName).concat(' ').concat(lastName);
  }
}
