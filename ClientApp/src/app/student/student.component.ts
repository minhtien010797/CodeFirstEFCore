import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})

export class StudentComponent {
  public students: Student[] = [];
  columns: ColumnHeader[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Student[]>(baseUrl + 'api/students').subscribe(result => {
      this.students = result;
    }, error => console.error(error));
    this.setColumns();
  }

  OnInit() {
  }

  setColumns() {
    this.columns = [
      {
        name: 'First Name',
        key: 'firstName'
      },
      {
        name: 'Last Name',
        key: 'lastName'
      },
      {
        name: 'Score',
        key: 'score'
      }
    ]
  }

}


interface ColumnHeader {
  name: string;
  isHide?: boolean;
  key: string;
}

interface Student {
  firstName: string;
  lastName: string;
  score: number;
}