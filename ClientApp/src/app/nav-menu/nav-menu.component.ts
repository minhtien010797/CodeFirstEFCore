import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthGuard } from '../guards/auth-guard.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  isLoggedIn : Observable<boolean>;

  constructor( private router: Router, public authService : AuthGuard) {
    // this.isLoggedIn = authService.isLoggedIn();
  }

  collapse() {
    this.isExpanded = false;
  }

  logOut() {
    localStorage.removeItem("jwt");
    this.router.navigate(["login"]);
}

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
