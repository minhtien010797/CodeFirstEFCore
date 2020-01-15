import { Component, Inject, ViewEncapsulation } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-data',
  templateUrl: './student-data.component.html',
  styleUrls: ['./student-data.component.css'], 
  encapsulation: ViewEncapsulation.None
})
export class StudentDataComponent {
  public students: Student[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Student[]>(baseUrl + 'api/students').toPromise().then(result => {
      this.students = result;
    }, error => console.error(error));
  }
}

interface Student {
  firstName: string;
  lastName: string;
  score: number;
}
