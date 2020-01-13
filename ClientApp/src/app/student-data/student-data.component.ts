import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-data',
  templateUrl: './student-data.component.html'
})
export class StudentDataComponent {
  public students: Student[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Student[]>(baseUrl + 'api/students').toPromise().then(result => {
      debugger;
      this.students = result;
    }, error => console.error(error));
  }
}

interface Student {
  firstName: string;
  lastName: string;
  score: number;
}
