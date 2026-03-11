#include <iostream>
#include <list>
#include <cstring>
#include <crypt.h>

using namespace std;

string target_salt = "$6$SvT3dVpN$";
string target_pw_hash = "$6$SvT3dVpN$lwb3GViLl0J0ntNk5BAWe2WtkbjSBMXtSkDCtZUkVhVPiz5X37WflWL4k3ZUusdoyh7IOUlSXE1jUHxIrg29p.";

char null_str[] = {'\0'}; 

// Define the maximum length for the password to be searched
#define MAX_LEN 15
list<char*> pwlist;

// Check if the pw and salt match the hash
int check_password(char* pw, char* salt, char* hash)
{
    char* res = crypt(pw, salt);
    
    // strcmp returns 0 if the two strings are exactly identical
    if (strcmp(res, hash) == 0) {
        cout << "MATCH !!! \n";
        return 1;
    }
    
    // If they don't match, return 0 immediately
    return 0;
}

char* exhaustive_search(char* charset, char* salt, char* target)
{
    char* current_password;
    char* new_password;
    int i, current_len;
    
    // Define the subset of special characters
    char specials[] = {'!', '@', '#', '\0'};

    // Begin by adding each character as a potential 1 character password
    for (i = 0; i < strlen(charset); i++){
        new_password = new char[2];
        new_password[0] = charset[i];
        new_password[1] = '\0';
        pwlist.push_back(new_password);
    }

    while(true){
        if (pwlist.empty()) return null_str;

        current_password = pwlist.front();
        current_len = strlen(current_password);

        // Check if current password is the target password
        if (check_password(current_password, salt, target)) {
            
            return current_password;
        }

        // Generate new passwords only if current length is less than maxlength
        if(current_len < MAX_LEN){
            
            // Check if the last character is a symbol
            char last_char = current_password[current_len - 1];
            bool ends_with_special = (last_char == '!' || last_char == '@' || last_char == '#');

            
            char* active_charset = ends_with_special ? specials : charset;

            for (i = 0; i < strlen(active_charset); i++){
                new_password = new char[current_len + 2];
                memcpy(new_password, current_password, current_len);
                new_password[current_len] = active_charset[i];
                new_password[current_len+1] = '\0';
                pwlist.push_back(new_password);
            }
        }
        
        // remove the front element as it didn't match the password
        pwlist.pop_front();
        
        
        delete[] current_password;
    }
}

int main()
{
    char* salt;
    char* target;
    char* password;
    
    // Define the full character set
    char charset[] = {'a', 'b', 'c', '1', '2', '!', '@', '#', '\0'};
    
    // Convert the salt from string to char*
    salt = new char[target_salt.length()+1];
    copy(target_salt.begin(), target_salt.end(), salt);
    salt[target_salt.length()] = '\0'; 
    
    // Convert the hash from string to char*
    target = new char[target_pw_hash.length()+1];
    copy(target_pw_hash.begin(), target_pw_hash.end(), target);
    target[target_pw_hash.length()] = '\0'; 
    
    cout << "Starting exhaustive search...\n";
    
    // Search
    password = exhaustive_search(charset, salt, target);
    
    if (strlen(password)!= 0) 
        cout << "Password successfully recovered: " << password << " \n";
    else 
        cout << "Failure to find password. Try a larger MAX_LEN. \n";
        
    delete[] salt;
    delete[] target;

        
    return 0;
}