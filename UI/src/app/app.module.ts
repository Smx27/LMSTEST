import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './Pages/Template/nav/nav.component';
import { FooterComponent } from './Pages/Template/footer/footer.component';
import { HomeComponent } from './Pages/home/home.component';
import { LoginComponent } from './Pages/Accounts/Student/login/login.component';
import { RegisterComponent } from './Pages/Accounts/Student/register/register.component';
import { ForgotPasswordComponent } from './Pages/Accounts/Student/forgot-password/forgot-password.component';
import { DashbordComponent } from './Pages/student/dashbord/dashbord.component';
import { CourseListComponent } from './Pages/student/course-list/course-list.component';
import { NotFoundComponent } from './Pages/Template/not-found/not-found.component';
import { SubscriptionComponent } from './Pages/student/subscription/subscription.component';
import { PaymentInfoComponent } from './Pages/student/payment-info/payment-info.component';
import { EditProfileComponent } from './Pages/student/edit-profile/edit-profile.component';
import { ComingSoonComponent } from './Pages/Template/coming-soon/coming-soon.component';
import { CourseResumeComponent } from './Pages/student/course-resume/course-resume.component';
import { BookmarkComponent } from './Pages/student/bookmark/bookmark.component';
import { CourseQuizComponent } from './Pages/student/course-quiz/course-quiz.component';
import { SettingsComponent } from './Pages/student/settings/settings.component';
import { DeactivateComponent } from './Pages/student/deactivate/deactivate.component';
import { StudentSidebarComponent } from './Pages/student/student-sidebar/student-sidebar.component';
import { NavMainComponent } from './Pages/Template/nav-main/nav-main.component';
import { NavLoginStatusComponent } from './Pages/Template/nav-login-status/nav-login-status.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    FooterComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    ForgotPasswordComponent,
    DashbordComponent,
    CourseListComponent,
    NotFoundComponent,
    SubscriptionComponent,
    PaymentInfoComponent,
    BookmarkComponent,
    EditProfileComponent,
    ComingSoonComponent,
    CourseResumeComponent,
    CourseQuizComponent,
    SettingsComponent,
    DeactivateComponent,
    StudentSidebarComponent,
    NavMainComponent,
    NavLoginStatusComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
