import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelper } from 'angular2-jwt';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable()
export class AuthGuard {
  isLoginSubject = new BehaviorSubject<boolean>(this.hasToken());
  
  constructor(private jwtHelper: JwtHelper, private router: Router) {
  }

  // canActivate() {
  //   var token = localStorage.getItem("jwt");
 
  //   if (token && !this.jwtHelper.isTokenExpired(token)){
  //     console.log(this.jwtHelper.decodeToken(token));
  //     return true;
  //   }
  //   this.router.navigate(["login"]);
  //   return false;
  // }
  
  // isLoggedIn() : Observable<boolean> {
  //   return this.isLoginSubject.asObservable();
  // }

  // login() : void {
  //   localStorage.setItem('jwt', 'JWT');
  //   this.isLoginSubject.next(true);
  // }

  // logout() : void {
  //   localStorage.removeItem('jwt');
  //   this.isLoginSubject.next(false);
  // }

  private hasToken():boolean{
    return !!localStorage.getItem('jwt');
  }

}