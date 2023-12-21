import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/home/home.component';
import { LoginComponent } from './Pages/Accounts/Student/login/login.component';
import { RegisterComponent } from './Pages/Accounts/Student/register/register.component';
import { ForgotPasswordComponent } from './Pages/Accounts/Student/forgot-password/forgot-password.component';
import { DashbordComponent } from './Pages/student/dashbord/dashbord.component';
import { NotFoundComponent } from './Pages/Template/not-found/not-found.component';
import { SubscriptionComponent } from './Pages/student/subscription/subscription.component';
import { PaymentInfoComponent } from './Pages/student/payment-info/payment-info.component';
import { EditProfileComponent } from './Pages/student/edit-profile/edit-profile.component';
import { ComingSoonComponent } from './Pages/Template/coming-soon/coming-soon.component';
import { CourseResumeComponent } from './Pages/student/course-resume/course-resume.component';
import { CourseQuizComponent } from './Pages/student/course-quiz/course-quiz.component';
import { SettingsComponent } from './Pages/student/settings/settings.component';
import { DeactivateComponent } from './Pages/student/deactivate/deactivate.component';
import { BookmarkComponent } from './Pages/student/bookmark/bookmark.component';
import { CourseListComponent } from './Pages/student/course-list/course-list.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'student/login', component:LoginComponent},
  {path:'student/register', component:RegisterComponent},
  {path:'student/forgot-password', component:ForgotPasswordComponent},
  {path:'student/dashbord', component:DashbordComponent},
  {path:'student/subscription', component:SubscriptionComponent},
  {path:'student/payment-info', component:PaymentInfoComponent},
  {path:'student/edit-profile', component:EditProfileComponent},
  {path:'student/course-list', component:CourseListComponent},
  {path:'student/course-resume', component:CourseResumeComponent},
  {path:'student/course-quiz', component:CourseQuizComponent},
  {path:'student/settings', component:SettingsComponent},
  {path:'student/deactivate', component:DeactivateComponent},
  {path:'student/bookmark', component:BookmarkComponent},
  {path:'not-found', component:NotFoundComponent},
  {path:'coming-soon', component:ComingSoonComponent},
  {path:'**',component:NotFoundComponent,pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
